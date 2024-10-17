﻿

namespace Basket.API.Basket.GetBasket
{
    public record GetBasketQuery(string UserName) : IQuery<GetBasketResult>;
    public record GetBasketResult(ShoppingCart Cart);

    public class GetBasketQueryHandler
        : IQueryHandler<GetBasketQuery, GetBasketResult>
    {

        public async Task<GetBasketResult> Handle(GetBasketQuery request, CancellationToken cancellationToken)
        {
            //var basket = await repository.GetBasket(query.UserName);

            return new GetBasketResult(new ShoppingCart("swn"));
        }
    }
}
