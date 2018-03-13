import { Component, Injector } from '@angular/core';
import { AddDetalleTipoProductoGenerated } from './add-detalle-tipo-producto-generated.component';

@Component({
  selector: 'add-detalle-tipo-producto',
  templateUrl: './add-detalle-tipo-producto.component.html'
})
export class AddDetalleTipoProductoComponent extends AddDetalleTipoProductoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
