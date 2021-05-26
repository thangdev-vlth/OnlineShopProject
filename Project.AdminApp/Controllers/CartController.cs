﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.ViewModels.cart;
using Project.AdminApp.Models;
using Project.Application.Catalog.Products;
using Project.Application.Exceptions;
using Project.Data.Entities;
using Project.ViewModels.Sales;
using Project.Application.Sales;

namespace Project.AdminApp.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICartService _cartService;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public CartController(IProductService productService, ICartService cartService, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _productService = productService;
            _signInManager = signInManager;
            _userManager = userManager;
            _cartService = cartService;
        }

        public IActionResult Index()
        {



            return View();
        }

        public IActionResult Checkout()
        {
            return View(GetCheckoutViewModel());
        }

        [HttpPost]
        public IActionResult Checkout(CheckoutViewModel request)
        {
            var model = GetCheckoutViewModel();
            var orderDetails = new List<OrderDetailVm>();
            foreach (var item in model.CartItems)
            {
                orderDetails.Add(new OrderDetailVm()
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity
                });
            }
            var checkoutRequest = new CheckoutRequest()
            {
                Address = request.CheckoutModel.Address,
                Name = request.CheckoutModel.Name,
                Email = request.CheckoutModel.Email,
                PhoneNumber = request.CheckoutModel.PhoneNumber,
                OrderDetails = orderDetails
            };
            //TODO: Add to API
            TempData["SuccessMsg"] = "Order puschased successful";
            return View(model);
        }

        [HttpGet]
        public IActionResult GetListItems()
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            CartViewModel currentCart = new CartViewModel();
            ClaimsPrincipal principal = HttpContext.User as ClaimsPrincipal;
            var result=_signInManager.IsSignedIn(principal);
            if (result)//đã đăng nhập thì lấy cart ở trong db rồi đồng bộ với cart trong session
            {
                //xử lí lấy cart từ db, 
                var userid = _userManager.GetUserId(principal);
                var getCartResult= _cartService.GetCart(userid);
                //end request db-cart
                //get cart from sesion
                CartViewModel SessionCart = new CartViewModel();
                if (session != null)
                    SessionCart.cartItem = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);//lấy cart từ session
                //synchronize session cart with dbcart
                if (getCartResult.IsSuccessed)
                {
                    var UserCart = getCartResult.ResultObj;
                    if (SessionCart.cartItem!=null)
                    {
                        bool exist;
                        foreach (var sessionItem in SessionCart.cartItem)
                        {
                            exist = false;
                            foreach (var userItem in UserCart.cartItem)
                            {
                                if (userItem.ProductId == sessionItem.ProductId)
                                {
                                    userItem.Quantity += sessionItem.Quantity;
                                    userItem.Price = sessionItem.Price;
                                    exist = true;
                                    break;
                                }
                            }
                            if (!exist)
                            {
                                UserCart.cartItem.Add(sessionItem);
                            }
                        }
                    }
                    return Ok(UserCart.cartItem);
                }
                else
                {
                    return Ok(currentCart.cartItem);
                }
            }
            //chưa đăng nhập, trả cart từ session 
            if (session != null)
                currentCart.cartItem = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            return Ok(currentCart.cartItem);
        }

        public async Task<IActionResult> AddToCart(int id)
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            ClaimsPrincipal principal = HttpContext.User as ClaimsPrincipal;
            var signIn = _signInManager.IsSignedIn(principal);
            var product = await _productService.GetById(id);
            CartViewModel currentCart = new CartViewModel();
            if (session != null)
                currentCart.cartItem = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);

            if (signIn)
            {
                //xử lí lấy cart từ db, 
                var userid = _userManager.GetUserId(principal);
                var getCartResult = _cartService.GetCart(userid);
                //end request db-cart
                if (getCartResult.IsSuccessed)
                {
                    currentCart = getCartResult.ResultObj;
                }
            }
            //ábdhjasbhjasbdhjasbdbasbhj
            int quantity = 1;
            if (currentCart.cartItem.Any(x => x.ProductId == id))
            {
                currentCart.cartItem.First(x => x.ProductId == id).Quantity +=1;
                if (signIn)
                {
                    var request = new CartUpdateRequest()
                    {
                        id = currentCart.id,
                        productId =id,
                        Quantity = currentCart.cartItem.First(x => x.ProductId == id).Quantity,
                        UserId = _userManager.GetUserId(principal)
                    };
                    await _cartService.UpdateQuantityInCart(request);
                    return Ok(currentCart.cartItem);
                }
            }
            else
            {
                var cartItem = new CartItemViewModel()
                {
                    ProductId = id,
                    Description = product.Description,
                    Image = product.ThumbnailImage,
                    Name = product.Name,
                    Price = product.Price,
                    Quantity = quantity
                };
                currentCart.cartItem.Add(cartItem);
                if (signIn)
                {
                    var request = new CartAddNewItemRequest()
                    {
                        id = currentCart.id,
                        productId = id,
                        Quantity = 1,
                        UserId = _userManager.GetUserId(principal),
                        principal=principal,
                        Price = product.Price
                    };
                    _cartService.AddNewItemToCart(request);
                    return Ok(currentCart.cartItem);
                }
            }
            HttpContext.Session.SetString(SystemConstants.CartSession, JsonConvert.SerializeObject(currentCart));
            return Ok(currentCart.cartItem);

        }

        public IActionResult UpdateCart(int id, int quantity)
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            ClaimsPrincipal principal = HttpContext.User as ClaimsPrincipal;
            var signIn = _signInManager.IsSignedIn(principal);
            CartViewModel currentCart = new CartViewModel();
            if (session != null)
                currentCart.cartItem = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            
            if (signIn)
            {
                //xử lí lấy cart từ db, 
                var userid = _userManager.GetUserId(principal);
                var getCartResult = _cartService.GetCart(userid);
                //end request db-cart
                if (getCartResult.IsSuccessed)
                {
                    currentCart = getCartResult.ResultObj;
                }
            }
            
            foreach (var item in currentCart.cartItem)
            {
                if (item.ProductId == id)
                {
                    if (quantity == 0)
                    {
                        currentCart.cartItem.Remove(item);
                    }
                    item.Quantity = quantity;
                    if (signIn)
                    {
                        var request = new CartUpdateRequest()
                        {
                            id = currentCart.id,
                            productId = item.ProductId,
                            Quantity = quantity,
                            UserId = _userManager.GetUserId(principal)
                        };
                        _cartService.UpdateQuantityInCart(request);
                        return Ok(currentCart);
                    }
                    
                }
            }
            HttpContext.Session.SetString(SystemConstants.CartSession, JsonConvert.SerializeObject(currentCart));
            return Ok(currentCart);
        }

        private CheckoutViewModel GetCheckoutViewModel()
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            var checkoutVm = new CheckoutViewModel()
            {
                CartItems = currentCart,
                CheckoutModel = new CheckoutRequest()
            };
            return checkoutVm;
        }
        
    }
}