import { Injectable } from "@nestjs/common";
import { PrismaService } from "../prisma/prisma.service";
import { ObjectServiceBase } from "./base/object.service.base";

@Injectable()
export class ObjectService extends ObjectServiceBase {
  constructor(protected readonly prisma: PrismaService) {
    super(prisma);
  }
}
