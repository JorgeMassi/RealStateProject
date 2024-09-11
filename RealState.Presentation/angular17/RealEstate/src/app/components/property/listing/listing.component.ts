import { Component, OnDestroy, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Property } from '../../../models/properties/property';
import { PropertyService } from '../../../services/property/property.service';
import { CardsComponent } from '../cards/cards.component';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-listing',
  standalone: true,
  imports: [CommonModule, CardsComponent, RouterModule],
  templateUrl: './listing.component.html',
  styleUrls: ['./listing.component.css']
})
export class ListingComponent implements OnInit {

  constructor(private service: PropertyService) { }
    properties = new Array<Property>();
    ngOnInit() {
        this.service.getProperties()
        .subscribe(
            data => {
                this.properties = data;
            },
            err => {
                console.log(err)
            },
            () => {
                console.log("Completed")
            });
      }
}