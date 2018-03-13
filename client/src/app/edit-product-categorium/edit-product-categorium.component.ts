import { Component, Injector } from '@angular/core';
import { EditProductCategoriumGenerated } from './edit-product-categorium-generated.component';

@Component({
  selector: 'edit-product-categorium',
  templateUrl: './edit-product-categorium.component.html'
})
export class EditProductCategoriumComponent extends EditProductCategoriumGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
