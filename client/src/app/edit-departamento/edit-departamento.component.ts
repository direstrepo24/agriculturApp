import { Component, Injector } from '@angular/core';
import { EditDepartamentoGenerated } from './edit-departamento-generated.component';

@Component({
  selector: 'edit-departamento',
  templateUrl: './edit-departamento.component.html'
})
export class EditDepartamentoComponent extends EditDepartamentoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
