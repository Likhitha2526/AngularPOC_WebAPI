import { Component, Input } from "@angular/core";
import { IVilla } from "../IVilla.interface";
import { Router } from "@angular/router";

@Component({
    selector: 'app-Villa-card',
    // template: `<h1> I am a card</h1>`
    templateUrl: 'Villa-card.component.html',
    styleUrls: ['Villa-card.component.css']


})
export class VillaCardComponent{
  @Input()
  villa!: IVilla;


    // Villa: any = {
    //   "id": 1,
    //   "name": "Royal Villa",
    //   "details": "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
    //   "rate": 200,
    //   "occupancy": 4,
    //   "sqft": 550,
    // }

    //in your constructor
  constructor(public router: Router){
  }


  //navigation link.
  navigateToProductDetail() {
    // Navigate to the product detail component with the product ID
    this.router.navigate(['/Villa-detail/', this.villa.id]);
  }

}
