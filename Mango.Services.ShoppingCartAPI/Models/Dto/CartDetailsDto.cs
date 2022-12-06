﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Mango.Services.ShoppingCartAPI.Models.Dto
{
    public class CartDetailsDto
    {
        public int CartDetilsId { get; set; }
        public int CartHeaderId{ get; set; }
        public virtual CartHeaderDto CartHeader { get; set; }

        public int ProductId { get; set; }
        public virtual ProductDto Product { get; set; }

        public int Count { get; set; }

    }
}
