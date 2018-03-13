import { Component, Injector } from '@angular/core';
import { LotesGenerated } from './lotes-generated.component';

@Component({
  selector: 'lotes',
  templateUrl: './lotes.component.html'
})
export class LotesComponent extends LotesGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
