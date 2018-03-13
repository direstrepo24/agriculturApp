import { Component, Injector } from '@angular/core';
import { AddCategoriaInsumoGenerated } from './add-categoria-insumo-generated.component';

@Component({
  selector: 'add-categoria-insumo',
  templateUrl: './add-categoria-insumo.component.html'
})
export class AddCategoriaInsumoComponent extends AddCategoriaInsumoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
