import { Injectable } from "@nestjs/common";
import { PrismaService } from "../prisma/prisma.service";
import { ObjectTypeServiceBase } from "./base/objectType.service.base";

@Injectable()
export class ObjectTypeService extends ObjectTypeServiceBase {
  constructor(protected readonly prisma: PrismaService) {
    super(prisma);
  }
}
