import { useFormik, validateYupSchema } from "formik";

const FormDetails = () => {
  const formik = useFormik({
    initialValues: { mobile: "", latitude: "", longitude: "", address: "" },
    onSubmit: (values) => {
      alert(JSON.stringify(values));
    },
    
  });

  return (
    <div class="row justify-content-center">
      <div class="col-md-5">
        <div class="card">
          <h2 class="card-title text-center">Hotel Onboarding</h2>
          <div class="card-body py-md-4">
            <form onSubmit={formik.handleSubmit}>
              {/* <div>
                                <input type="text" value={formik.values.mobile} onChange={formik.handleChange} />
                            </div> */}

              <div class="form-group">
                <input
                  type="text"
                  class="form-control"
                  id="mobile"
                  name="mobile"
                  placeholder="Mobile"
                  value={formik.values.mobile}
                  onChange={formik.handleChange}
                />
              </div>

              <div class="form-group">
                <input
                  type="text"
                  class="form-control"
                  placeholder="Latitude"
                  id="latitude"
                  name="latitude"
                  value={formik.values.latitude}
                  onChange={formik.handleChange}
                />
              </div>

              <div class="form-group">
                <input
                  type="text"
                  class="form-control"
                  placeholder="Longitude"
                  id="longitude"
                  value={formik.values.longitude}
                  onChange={formik.handleChange}
                />
              </div>
              <div class="form-group">
                <textarea
                  class="form-control"
                  placeholder="Address"
                  id="address"
                  value={formik.values.address}
                  onChange={formik.handleChange}
                ></textarea>
              </div>

              <div class="d-flex flex-row align-items-center justify-content-between">
                Login
                <button class="btn btn-primary" type="submit">
                  Create Account
                </button>
              </div>
            </form>
          </div>
        </div>
      </div>
    </div>
  );
};

export default FormDetails;
