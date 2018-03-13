import { Component, Injector } from '@angular/core';
import { AddDepartamentoGenerated } from './add-departamento-generated.component';

@Component({
  selector: 'add-departamento',
  templateUrl: './add-departamento.component.html'
})
export class AddDepartamentoComponent extends AddDepartamentoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
