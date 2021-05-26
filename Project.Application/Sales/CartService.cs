using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.Data.EF;
using Project.Data.Entities;
using Project.Utilities.Exceptions;
using Project.ViewModels.cart;
using Project.ViewModels.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Sales
{
    public class CartService : ICartService
    {
        private readonly ProjectDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        /* private readonly IStorageService _storageService;
         private const string USER_CONTENT_FOLDER_NAME = "user-content";*/
        public CartService(ProjectDbContext projectDbContext, UserManager<AppUser> userManager)
        {
            _context = projectDbContext;
            _userManager = userManager;
            //_storageService = storageService;
        }

        public RequestResult<bool> AddNewItemToCart(CartAddNewItemRequest request)
        {
            try
            {
                var user = _userManager.Users.Where(user => user.Id == request.UserId).First();
                Cart cartRecord = new Cart()
                {
                    //Id = request.id,
                    ProductId = request.productId,
                    AppUser = user,
                    Quantity = request.Quantity,
                    Price = request.Price,
                    DateCreated = DateTime.Now
                };
                _context.Carts.Add(cartRecord);
                _context.SaveChanges();
                return new RequestSuccessResult<bool>();
            }
            catch (Exception e)
            {

                return new RequestErrorResult<bool>(e.Message);
            }
        }

        public RequestResult<CartViewModel> GetCart(string userId)
        {
            try
            {
                var cart = _context.Carts.Where(cart => cart.UserId == userId).Join(_context.Products.Include(p => p.ProductImages), // the source table of the inner join
                      cart => cart.ProductId,        // Select the primary key (the first part of the "on" clause in an sql "join" statement)
                      product => product.Id,   // Select the foreign key (the second part of the "on" clause)
                      (cart, product) => new { Cart = cart, Product = product });
                
                var CartInDb = new CartViewModel()
                {
                    id=cart.Select(cart=>cart.Cart.Id).First(),
                    UserId= cart.Select(cart => cart.Cart.UserId).First(),
                    DateCreated= cart.Select(cart => cart.Cart.DateCreated).First(),
                    cartItem= cart.Select(cart=>new CartItemViewModel()
                    {
                        ProductId = cart.Cart.ProductId,
                        Description = cart.Product.Description,
                        Image = cart.Product.ProductImages.First().ImagePath,
                        Name = cart.Product.Name,
                        Price = cart.Cart.Price,
                        Quantity = cart.Cart.Quantity
                    }).ToList()
                };
                if (CartInDb.cartItem== null)
                {
                    return new RequestSuccessResult<CartViewModel>(null);
                }
                return new RequestSuccessResult<CartViewModel>(CartInDb);
            }
            catch (Exception e)
            {

                return new RequestErrorResult<CartViewModel>(e.InnerException.Message);
            }
        }

        public async Task<RequestResult<bool>> UpdateQuantityInCart(CartUpdateRequest request)
        {
            try
            {
                //var cart =  _context.Carts.Where(cart=> cart.Id==request.id&& cart.ProductId==request.productId&&cart.UserId.Equals(request.UserId)).First() ;
                //var cart = await _context.Carts.FirstAsync(request.id,request.productId,request.UserId);
                var cart = (from cartrow in _context.Carts where  cartrow.ProductId == request.productId && cartrow.UserId.Equals(request.UserId) select cartrow).FirstOrDefault();
                
                if (cart == null) throw new ProjectException($"Cannot find a product with id: {request.id}");
                if (request.Quantity==0)
                {
                    _context.Remove(cart);
                    _context.SaveChanges();
                }
                else
                {
                    cart.Quantity = request.Quantity;
                }

                 _context.SaveChanges();
                return new RequestSuccessResult<bool>();
            }
            catch (Exception e)
            {

                return new RequestErrorResult<bool>(e.Message);
            }
        }

       
    }
}
