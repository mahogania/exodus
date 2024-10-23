import { Module, forwardRef } from "@nestjs/common";
import { AuthModule } from "../auth/auth.module";
import { ObjectTypeModuleBase } from "./base/objectType.module.base";
import { ObjectTypeService } from "./objectType.service";
import { ObjectTypeController } from "./objectType.controller";
import { ObjectTypeResolver } from "./objectType.resolver";

@Module({
  imports: [ObjectTypeModuleBase, forwardRef(() => AuthModule)],
  controllers: [ObjectTypeController],
  providers: [ObjectTypeService, ObjectTypeResolver],
  exports: [ObjectTypeService],
})
export class ObjectTypeModule {}
