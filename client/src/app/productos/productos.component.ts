import { Component, Injector } from '@angular/core';
import { ProductosGenerated } from './productos-generated.component';

@Component({
  selector: 'productos',
  templateUrl: './productos.component.html'
})
export class ProductosComponent extends ProductosGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
