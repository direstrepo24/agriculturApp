import { Component, Injector } from '@angular/core';
import { EditUnidadMedidaGenerated } from './edit-unidad-medida-generated.component';

@Component({
  selector: 'edit-unidad-medida',
  templateUrl: './edit-unidad-medida.component.html'
})
export class EditUnidadMedidaComponent extends EditUnidadMedidaGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
