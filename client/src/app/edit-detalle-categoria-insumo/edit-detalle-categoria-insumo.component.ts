import { Component, Injector } from '@angular/core';
import { EditDetalleCategoriaInsumoGenerated } from './edit-detalle-categoria-insumo-generated.component';

@Component({
  selector: 'edit-detalle-categoria-insumo',
  templateUrl: './edit-detalle-categoria-insumo.component.html'
})
export class EditDetalleCategoriaInsumoComponent extends EditDetalleCategoriaInsumoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
