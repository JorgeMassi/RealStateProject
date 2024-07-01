import { PhysicalLocation } from "../physicalLocation/physical-location";


export class Property {
    constructor()
    {
        this.id = '';
        this.price = new BusinessPrice;
        this.description = 'No description';
        this.image = '';
        this.location = new PhysicalLocation();
    }
    id: String;
    price: BusinessPrice;
    description: String;
    image: String;
    location : PhysicalLocation;

    
}
