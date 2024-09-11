import { Address } from "../Addresses/address";
import { Condition } from "../Enums/condition";
import { Price } from "../Prices/price";
import { Typology } from "../typologeis/typology";
import { User } from "../Users/user";

export class Property {
    id: string;
    typology: Typology;
    location: Address;
    yearBuilt: number;
    totalArea: number;
    rooms: number;
    floors: number;
    bathrooms: number;
    garage: boolean;
    energyRating: string;
    condition: Condition;
    description: string;
    features: string;
    user: User;
    price: Price;

    constructor() {
        this.id = '';
        this.typology = new Typology();
        this.location = new Address();
        this.yearBuilt = 0;
        this.totalArea = 0;
        this.rooms = 0;
        this.floors = 0;
        this.bathrooms = 0;
        this.garage = false;
        this.energyRating = '';
        this.description = ''; 
        this.features = '';
        this.user = new User();
        this.price = new Price();
        this.condition = Condition.New;
    }
}
