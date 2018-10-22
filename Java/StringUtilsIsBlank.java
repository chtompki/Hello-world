/**
 * A class for determining if a <code>String</code> is either <code>null</code> or <code>""</code>.
 *
 * @author Rob Tompkins
 */
public static class StringUtilsIsBlank {

    private StringUtils() {
        //Hide utility class constructor
    }

    /**
     * Returns <code>true</code> if a <code>String</code> is either <code>null</code> or if the <code>String</code>
     * is <code>""</code>.
     * @param str is the <code>String</code> to check.
     * @return <code>true</code> if the <code>String</code>.
     */
    public static boolean isBlank(final String str) {
        return str == null || str.length == 0;
    }

}