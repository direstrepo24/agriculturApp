import { Component, Injector } from '@angular/core';
import { EditDetalleTipoProductoGenerated } from './edit-detalle-tipo-producto-generated.component';

@Component({
  selector: 'edit-detalle-tipo-producto',
  templateUrl: './edit-detalle-tipo-producto.component.html'
})
export class EditDetalleTipoProductoComponent extends EditDetalleTipoProductoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
