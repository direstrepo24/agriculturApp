import { Component, Injector } from '@angular/core';
import { DetalleCategoriaInsumosGenerated } from './detalle-categoria-insumos-generated.component';

@Component({
  selector: 'detalle-categoria-insumos',
  templateUrl: './detalle-categoria-insumos.component.html'
})
export class DetalleCategoriaInsumosComponent extends DetalleCategoriaInsumosGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
