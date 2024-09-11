import { PriceValue } from "../Enums/price-value";

export interface Price {
    id: number;
    currency: string;
    value: number;
    priceValue: PriceValue;
}
export class Price {
    constructor()
    {
        this.id = 0;
        this.currency = '';
        this.value = 0;
        this.priceValue = PriceValue.Total;
    }
}