import { PhysicalLocation } from "../physicalLocation/physical-location";

export class Property {
    constructor()
    {
        this.id = '';
        this.price = 0;
        this.description = 'No description';
        this.image = '';
        this.location = new PhysicalLocation();
    }
    id: String;
    price: Number;
    description: String;
    image: String;
    location : PhysicalLocation;

    
}
