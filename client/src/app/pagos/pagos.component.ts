import { Component, Injector } from '@angular/core';
import { PagosGenerated } from './pagos-generated.component';

@Component({
  selector: 'pagos',
  templateUrl: './pagos.component.html'
})
export class PagosComponent extends PagosGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
