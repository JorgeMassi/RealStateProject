import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterLink, RouterModule} from '@angular/router';
import { Property } from '../../../models/properties/property';
import { Typology } from '../../../models/typologeis/typology';
import { User } from '../../../models/Users/user';
import { Price } from '../../../models/Prices/price';
import { Address } from '../../../models/Addresses/address';
import { Condition } from '../../../models/Enums/condition';
import { PriceValue } from '../../../models/Enums/price-value';
import { UserType } from '../../../models/Enums/user-type';

@Component({
  selector: 'app-cards',
  standalone: true,
  imports: [CommonModule, RouterLink],
  templateUrl: './cards.component.html',
  styleUrl: './cards.component.css'
})
export class CardsComponent {
  
  constructor(private router: RouterModule){}
  
  @Input()
  property!: Property;
  typology!: Typology;
  user!: User;
  price!: Price;
  address! : Address;
  condition! : Condition;
  priceValue! : PriceValue;
  userType! : UserType;

  navigate(){
    this.router
  }

  //navigateToDetails(): void {
    // Navigate to the property details view with the property ID
    //this.router.navigate(['/property-view', this.property.id]);
  


  //@Input() title: string = 'Beautiful House';
  //@Input() content: string = 'This house has 3 bedrooms and 2 bathrooms, located in a quiet neighborhood.';
  //@Input() imageUrl?: string = '/assets/!Img/house-2368389_1280.jpg';

}
