import * as React from "react";

import {
  Create,
  SimpleForm,
  CreateProps,
  ReferenceInput,
  SelectInput,
  ReferenceArrayInput,
  SelectArrayInput,
} from "react-admin";

import { ObjectTitle } from "../object/ObjectTitle";
import { TaskTitle } from "../task/TaskTitle";

export const ActionCreate = (props: CreateProps): React.ReactElement => {
  return (
    <Create {...props}>
      <SimpleForm>
        <ReferenceInput source="object.id" reference="Object" label="Object">
          <SelectInput optionText={ObjectTitle} />
        </ReferenceInput>
        <ReferenceArrayInput source="tasks" reference="Task">
          <SelectArrayInput
            optionText={TaskTitle}
            parse={(value: any) => value && value.map((v: any) => ({ id: v }))}
            format={(value: any) => value && value.map((v: any) => v.id)}
          />
        </ReferenceArrayInput>
      </SimpleForm>
    </Create>
  );
};
