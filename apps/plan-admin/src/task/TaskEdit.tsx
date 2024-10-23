import * as React from "react";
import {
  Edit,
  SimpleForm,
  EditProps,
  ReferenceInput,
  SelectInput,
} from "react-admin";
import { ActionTitle } from "../action/ActionTitle";
import { StepTitle } from "../step/StepTitle";

export const TaskEdit = (props: EditProps): React.ReactElement => {
  return (
    <Edit {...props}>
      <SimpleForm>
        <ReferenceInput source="action.id" reference="Action" label="Action">
          <SelectInput optionText={ActionTitle} />
        </ReferenceInput>
        <div />
        <SelectInput
          source="kind"
          label="Kind"
          choices={[
            { label: "Human", value: "Human" },
            { label: "System", value: "System" },
          ]}
          optionText="label"
          allowEmpty
          optionValue="value"
        />
        <ReferenceInput source="step.id" reference="Step" label="Step">
          <SelectInput optionText={StepTitle} />
        </ReferenceInput>
      </SimpleForm>
    </Edit>
  );
};
