import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { PropertyCardsComponent } from '../property-cards/property-cards.component';
import { Property } from '../../model/property/property';
import { PhysicalLocation } from '../../model/physicalLocation/physical-location';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-property-listing',
  standalone: true,
  imports: [CommonModule, PropertyCardsComponent],
  templateUrl: './property-listing.component.html',
  styleUrl: './property-listing.component.css'
})
export class PropertyListingComponent {
  constructor(private http: HttpClient) { }

    property = new Array<Property>();

    loadStaticData() {
        let location = new PhysicalLocation();
        location.id = 8;
        location.name = 'Portugal';
        let property = new Property();
        property.id = '378326d7-744e-41ba-b98f-0823cc57fea9';
        property.price = 100;
        property.description = 'Primeiro Apartamento';
        property.location = location;

        this.property = [];
        this.property.push(property);
    }

    loadDynamicData() {
        let url = 'https://localhost:5120/api/';
        this.http.get<Array<Property>>(url)
            .subscribe((data) =>  {
                this.property = data
            });
    }

}
