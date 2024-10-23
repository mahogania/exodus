import { Module, forwardRef } from "@nestjs/common";
import { AuthModule } from "../auth/auth.module";
import { AssociationTypeModuleBase } from "./base/associationType.module.base";
import { AssociationTypeService } from "./associationType.service";
import { AssociationTypeController } from "./associationType.controller";
import { AssociationTypeResolver } from "./associationType.resolver";

@Module({
  imports: [AssociationTypeModuleBase, forwardRef(() => AuthModule)],
  controllers: [AssociationTypeController],
  providers: [AssociationTypeService, AssociationTypeResolver],
  exports: [AssociationTypeService],
})
export class AssociationTypeModule {}
