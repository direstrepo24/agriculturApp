import { Component, Injector } from '@angular/core';
import { AddUnidadMedidaGenerated } from './add-unidad-medida-generated.component';

@Component({
  selector: 'add-unidad-medida',
  templateUrl: './add-unidad-medida.component.html'
})
export class AddUnidadMedidaComponent extends AddUnidadMedidaGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
