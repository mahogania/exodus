import { Module, forwardRef } from "@nestjs/common";
import { AuthModule } from "../auth/auth.module";
import { EventTypeModuleBase } from "./base/eventType.module.base";
import { EventTypeService } from "./eventType.service";
import { EventTypeController } from "./eventType.controller";
import { EventTypeResolver } from "./eventType.resolver";

@Module({
  imports: [EventTypeModuleBase, forwardRef(() => AuthModule)],
  controllers: [EventTypeController],
  providers: [EventTypeService, EventTypeResolver],
  exports: [EventTypeService],
})
export class EventTypeModule {}
