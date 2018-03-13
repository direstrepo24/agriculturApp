import { Component, Injector } from '@angular/core';
import { AddTipoProductoGenerated } from './add-tipo-producto-generated.component';

@Component({
  selector: 'add-tipo-producto',
  templateUrl: './add-tipo-producto.component.html'
})
export class AddTipoProductoComponent extends AddTipoProductoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
