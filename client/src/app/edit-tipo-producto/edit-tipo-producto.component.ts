import { Component, Injector } from '@angular/core';
import { EditTipoProductoGenerated } from './edit-tipo-producto-generated.component';

@Component({
  selector: 'edit-tipo-producto',
  templateUrl: './edit-tipo-producto.component.html'
})
export class EditTipoProductoComponent extends EditTipoProductoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
