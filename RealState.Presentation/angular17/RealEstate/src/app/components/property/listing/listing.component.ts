import { Component, OnDestroy, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Property } from '../../../models/properties/property';
import { PropertyService } from '../../../services/property/property.service';
import { CardsComponent } from '../cards/cards.component';
import { RouterModule } from '@angular/router';
import { TypologyService } from '../../../services/typology/typology.service';
import { Typology } from '../../../models/typologeis/typology';
import { forkJoin } from 'rxjs';
import { Price } from '../../../models/Prices/price';
import { PriceService } from '../../../services/price/price.service';

@Component({
  selector: 'app-listing',
  standalone: true,
  imports: [CommonModule, CardsComponent, RouterModule],
  templateUrl: './listing.component.html',
  styleUrls: ['./listing.component.css']
})
export class ListingComponent implements OnInit {

  constructor(
    private service: PropertyService, 
    private typService : TypologyService,
    private priceService : PriceService,
  ) { }

  properties = new Array<Property>();
  typologies = new Array<Typology>();
  prices = new Array<Price>()



    ngOnInit() { 
      forkJoin({
        properties: this.service.getProperties(),
        typologies: this.typService.getTypologies(),
        prices: this.priceService.getPrices()

      })
      .subscribe(
        ({properties, typologies, prices}) =>{
          this.properties = properties;
          this.typologies = typologies;
          this.prices= prices

          this.properties.forEach(property => {
            property.typology = this.typologies.find(typology => typology.name === property.typology?.name);
        });
        }, 
          err => {
                console.log(err)
            },
            () => {
                console.log("Completed")
            });
      }
}