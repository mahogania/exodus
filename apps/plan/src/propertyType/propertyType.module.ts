import { Module, forwardRef } from "@nestjs/common";
import { AuthModule } from "../auth/auth.module";
import { PropertyTypeModuleBase } from "./base/propertyType.module.base";
import { PropertyTypeService } from "./propertyType.service";
import { PropertyTypeController } from "./propertyType.controller";
import { PropertyTypeResolver } from "./propertyType.resolver";

@Module({
  imports: [PropertyTypeModuleBase, forwardRef(() => AuthModule)],
  controllers: [PropertyTypeController],
  providers: [PropertyTypeService, PropertyTypeResolver],
  exports: [PropertyTypeService],
})
export class PropertyTypeModule {}
