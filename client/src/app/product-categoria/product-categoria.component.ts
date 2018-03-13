import { Component, Injector } from '@angular/core';
import { ProductCategoriaGenerated } from './product-categoria-generated.component';

@Component({
  selector: 'product-categoria',
  templateUrl: './product-categoria.component.html'
})
export class ProductCategoriaComponent extends ProductCategoriaGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
