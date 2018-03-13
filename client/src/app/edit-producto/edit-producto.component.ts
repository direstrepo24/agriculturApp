import { Component, Injector } from '@angular/core';
import { EditProductoGenerated } from './edit-producto-generated.component';

@Component({
  selector: 'edit-producto',
  templateUrl: './edit-producto.component.html'
})
export class EditProductoComponent extends EditProductoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
