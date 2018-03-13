import { Component, Injector } from '@angular/core';
import { MetodoPagosGenerated } from './metodo-pagos-generated.component';

@Component({
  selector: 'metodo-pagos',
  templateUrl: './metodo-pagos.component.html'
})
export class MetodoPagosComponent extends MetodoPagosGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
