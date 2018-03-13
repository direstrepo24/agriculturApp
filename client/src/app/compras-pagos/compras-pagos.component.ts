import { Component, Injector } from '@angular/core';
import { ComprasPagosGenerated } from './compras-pagos-generated.component';

@Component({
  selector: 'compras-pagos',
  templateUrl: './compras-pagos.component.html'
})
export class ComprasPagosComponent extends ComprasPagosGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
