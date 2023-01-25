﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Domain.Validation;
using System;

namespace Catalogo.Domain.Entities
{
    public sealed class Product : Entity
    {
        public Product(string name, string description, decimal price, string imageUrl,
            int stock, DateTime dateRegistration)
        {
            ValidateDomain(name, description, price, imageUrl, stock, dateRegistration);
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public string ImageUrl { get; private set; }
        public int Stock { get; private set; }
        public DateTime DateRegistration { get; private set; }

        public void Update(string name, string description, decimal price, string imageUrl,
            int stock, DateTime dateRegistration, int categoryId)
        {
            ValidateDomain(name, description, price, imageUrl, stock, dateRegistration);
            CategoryId = categoryId;
        }

        private void ValidateDomain(string name, string description, decimal price, string imageUrl,
            int stock, DateTime dateRegistration)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "Nome inválido. O nome é obrigatório");

            DomainExceptionValidation.When(name.Length < 3,
                "O nome deve ter no mínimo 3 caracteres");

            DomainExceptionValidation.When(string.IsNullOrEmpty(description),
                "Descrição inválida. A descrição é obrigatória");

            DomainExceptionValidation.When(description.Length < 5,
                "A descrição deve ter no mínimo 5 caracteres");

            DomainExceptionValidation.When(price < 0, "Valor do preço inválido");

            DomainExceptionValidation.When(imageUrl?.Length > 250,
                "O nome da imagem não pode exceder 250 caracteres");

            DomainExceptionValidation.When(stock < 0, "Estoque inválido");

            Name = name;
            Description = description;
            Price = price;
            ImageUrl = imageUrl;
            Stock = stock;
            DateRegistration = dateRegistration;

        }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
