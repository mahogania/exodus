import { Module, forwardRef } from "@nestjs/common";
import { AuthModule } from "../auth/auth.module";
import { StepModuleBase } from "./base/step.module.base";
import { StepService } from "./step.service";
import { StepController } from "./step.controller";
import { StepResolver } from "./step.resolver";

@Module({
  imports: [StepModuleBase, forwardRef(() => AuthModule)],
  controllers: [StepController],
  providers: [StepService, StepResolver],
  exports: [StepService],
})
export class StepModule {}
