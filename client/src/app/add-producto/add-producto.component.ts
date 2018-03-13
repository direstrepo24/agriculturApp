import { Component, Injector } from '@angular/core';
import { AddProductoGenerated } from './add-producto-generated.component';

@Component({
  selector: 'add-producto',
  templateUrl: './add-producto.component.html'
})
export class AddProductoComponent extends AddProductoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
