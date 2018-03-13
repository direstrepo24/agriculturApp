import { Component, Injector } from '@angular/core';
import { AddLoteGenerated } from './add-lote-generated.component';

@Component({
  selector: 'add-lote',
  templateUrl: './add-lote.component.html'
})
export class AddLoteComponent extends AddLoteGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
