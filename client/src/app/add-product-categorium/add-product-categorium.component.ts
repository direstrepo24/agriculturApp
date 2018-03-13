import { Component, Injector } from '@angular/core';
import { AddProductCategoriumGenerated } from './add-product-categorium-generated.component';

@Component({
  selector: 'add-product-categorium',
  templateUrl: './add-product-categorium.component.html'
})
export class AddProductCategoriumComponent extends AddProductCategoriumGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
