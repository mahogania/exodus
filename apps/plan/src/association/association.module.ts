import { Module, forwardRef } from "@nestjs/common";
import { AuthModule } from "../auth/auth.module";
import { AssociationModuleBase } from "./base/association.module.base";
import { AssociationService } from "./association.service";
import { AssociationController } from "./association.controller";
import { AssociationResolver } from "./association.resolver";

@Module({
  imports: [AssociationModuleBase, forwardRef(() => AuthModule)],
  controllers: [AssociationController],
  providers: [AssociationService, AssociationResolver],
  exports: [AssociationService],
})
export class AssociationModule {}
