import { Component, Injector } from '@angular/core';
import { EditLoteGenerated } from './edit-lote-generated.component';

@Component({
  selector: 'edit-lote',
  templateUrl: './edit-lote.component.html'
})
export class EditLoteComponent extends EditLoteGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
