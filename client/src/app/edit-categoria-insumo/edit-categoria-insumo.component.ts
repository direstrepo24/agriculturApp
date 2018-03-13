import { Component, Injector } from '@angular/core';
import { EditCategoriaInsumoGenerated } from './edit-categoria-insumo-generated.component';

@Component({
  selector: 'edit-categoria-insumo',
  templateUrl: './edit-categoria-insumo.component.html'
})
export class EditCategoriaInsumoComponent extends EditCategoriaInsumoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
