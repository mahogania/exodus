import { Module, forwardRef } from "@nestjs/common";
import { AuthModule } from "../auth/auth.module";
import { ObjectModuleBase } from "./base/object.module.base";
import { ObjectService } from "./object.service";
import { ObjectController } from "./object.controller";
import { ObjectResolver } from "./object.resolver";

@Module({
  imports: [ObjectModuleBase, forwardRef(() => AuthModule)],
  controllers: [ObjectController],
  providers: [ObjectService, ObjectResolver],
  exports: [ObjectService],
})
export class ObjectModule {}
