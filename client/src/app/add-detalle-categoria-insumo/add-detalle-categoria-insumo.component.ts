import { Component, Injector } from '@angular/core';
import { AddDetalleCategoriaInsumoGenerated } from './add-detalle-categoria-insumo-generated.component';

@Component({
  selector: 'add-detalle-categoria-insumo',
  templateUrl: './add-detalle-categoria-insumo.component.html'
})
export class AddDetalleCategoriaInsumoComponent extends AddDetalleCategoriaInsumoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
