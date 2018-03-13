import { Component, Injector } from '@angular/core';
import { EditTipoInsumoGenerated } from './edit-tipo-insumo-generated.component';

@Component({
  selector: 'edit-tipo-insumo',
  templateUrl: './edit-tipo-insumo.component.html'
})
export class EditTipoInsumoComponent extends EditTipoInsumoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
