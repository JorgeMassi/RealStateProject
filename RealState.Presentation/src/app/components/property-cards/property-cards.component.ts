import { Component, Input } from '@angular/core';
import { Property } from '../../model/property/property';

@Component({
  selector: 'app-property-cards',
  standalone: true,
  imports: [],
  templateUrl: './property-cards.component.html',
  styleUrl: './property-cards.component.css'
})
export class PropertyCardsComponent {
  @Input() property!: Property
}
