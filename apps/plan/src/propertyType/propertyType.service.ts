import { Injectable } from "@nestjs/common";
import { PrismaService } from "../prisma/prisma.service";
import { PropertyTypeServiceBase } from "./base/propertyType.service.base";

@Injectable()
export class PropertyTypeService extends PropertyTypeServiceBase {
  constructor(protected readonly prisma: PrismaService) {
    super(prisma);
  }
}
