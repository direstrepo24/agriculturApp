import { Component, Injector } from '@angular/core';
import { DepartamentosGenerated } from './departamentos-generated.component';

@Component({
  selector: 'departamentos',
  templateUrl: './departamentos.component.html'
})
export class DepartamentosComponent extends DepartamentosGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
